USE EvaluacionCodesarrollo;
GO

-- ==============================================================================
-- INSERCIÓN DE DATOS DE PRUEBA (SEED)
-- ==============================================================================

-- 1. Insertar Tipos de Garantía
-- Se requieren al menos PRENDARIA (para el filtro) y otra para probar que no la sume.
INSERT INTO Tipo_Garantia (IdTipoGarantia, NombreGarantia)
VALUES 
    (1, 'PRENDARIA'),
    (2, 'QUIROGRAFARIA');
GO

-- 2. Insertar Créditos
INSERT INTO Credito (NumeroCredito, Sucursal, EstatusCredito, IdTipoGarantia)
VALUES 
    (1001, 1, 'VIGENTE', 1),   -- Cumple todo (Vigente y Prendaria)
    (1002, 1, 'CANCELADO', 1), -- No debe sumar (Está Cancelado)
    (1003, 2, 'VIGENTE', 2),   -- No debe sumar (Es Quirografaria)
    (1004, 2, 'VIGENTE', 1);   -- Cumple todo (Vigente y Prendaria)
GO

-- 3. Insertar Cuotas
-- Usamos DATEADD para generar fechas de vencimiento dinámicas basadas en hoy.
INSERT INTO Cuota_Credito (NumeroCredito, Sucursal, NumeroCuota, FechaVencimiento, Capital, Interes, Mora, Pagada)
VALUES 
    -- ==========================================
    -- DATOS VÁLIDOS (Deben aparecer en el SUM)
    -- ==========================================
    
    -- Banda 1 a 30 días (Hace 15 días) -> Capital: 100.00
    (1001, 1, 1, DATEADD(DAY, -15, GETDATE()), 100.00, 10.00, 2.00, 'NO'),
    
    -- Banda 31 a 90 días (Hace 45 días) -> Capital: 200.00
    (1001, 1, 2, DATEADD(DAY, -45, GETDATE()), 200.00, 20.00, 5.00, 'NO'),
    
    -- Banda 91 a 180 días (Hace 120 días) -> Capital: 300.00
    (1004, 2, 1, DATEADD(DAY, -120, GETDATE()), 300.00, 30.00, 15.00, 'NO'),
    
    -- Banda 181 a 360 días (Hace 200 días) -> Capital: 400.00
    (1004, 2, 2, DATEADD(DAY, -200, GETDATE()), 400.00, 40.00, 25.00, 'NO'),
    
    -- Banda Mayores de 360 días (Hace 400 días) -> Capital: 500.00
    (1001, 1, 3, DATEADD(DAY, -400, GETDATE()), 500.00, 50.00, 50.00, 'NO'),

    -- ==========================================
    -- DATOS TRAMPA (NO deben aparecer en el SUM)
    -- ==========================================

    -- Trampa 1: Cuota ya PAGADA (Aunque cumpla los días, no debe sumar)
    (1001, 1, 4, DATEADD(DAY, -20, GETDATE()), 999.00, 10.00, 0.00, 'SI'),
    
    -- Trampa 2: Crédito CANCELADO (Credito 1002)
    (1002, 1, 1, DATEADD(DAY, -50, GETDATE()), 888.00, 20.00, 5.00, 'NO'),
    
    -- Trampa 3: Garantía QUIROGRAFARIA (Credito 1003)
    (1003, 2, 1, DATEADD(DAY, -100, GETDATE()), 777.00, 30.00, 10.00, 'NO'),
    
    -- Trampa 4: Cuota que aún NO VENCE (Vence en 10 días, DATEDIFF será negativo)
    (1001, 1, 5, DATEADD(DAY, 10, GETDATE()), 1000.00, 15.00, 0.00, 'NO');
GO