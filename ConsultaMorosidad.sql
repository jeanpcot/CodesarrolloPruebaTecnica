USE EvaluacionCodesarrollo;
GO
-- ------------------------------------------------------------------------------
-- 3. CONSULTA (DML) - Cálculo de bandas de morosidad
-- ------------------------------------------------------------------------------

SELECT 
    -- Banda 1: 1 a 30 días vencidos
    SUM(CASE 
        WHEN DATEDIFF(DAY, cc.FechaVencimiento, GETDATE()) BETWEEN 1 AND 30 THEN cc.Capital 
        ELSE 0 
    END) AS [1 a 30 dias],
    
    -- Banda 2: 31 a 90 días vencidos
    SUM(CASE 
        WHEN DATEDIFF(DAY, cc.FechaVencimiento, GETDATE()) BETWEEN 31 AND 90 THEN cc.Capital 
        ELSE 0 
    END) AS [31 a 90 dias],
    
    -- Banda 3: 91 a 180 días vencidos
    SUM(CASE 
        WHEN DATEDIFF(DAY, cc.FechaVencimiento, GETDATE()) BETWEEN 91 AND 180 THEN cc.Capital 
        ELSE 0 
    END) AS [91 a 180 dias],
    
    -- Banda 4: 181 a 360 días vencidos
    SUM(CASE 
        WHEN DATEDIFF(DAY, cc.FechaVencimiento, GETDATE()) BETWEEN 181 AND 360 THEN cc.Capital 
        ELSE 0 
    END) AS [181 a 360 dias],
    
    -- Banda 5: Mayores de 360 días vencidos
    SUM(CASE 
        WHEN DATEDIFF(DAY, cc.FechaVencimiento, GETDATE()) > 360 THEN cc.Capital 
        ELSE 0 
    END) AS [Mayores de 360 dias]

FROM Cuota_Credito cc
INNER JOIN Credito c 
    ON cc.NumeroCredito = c.NumeroCredito 
    AND cc.Sucursal = c.Sucursal
INNER JOIN Tipo_Garantia tg 
    ON c.IdTipoGarantia = tg.IdTipoGarantia
WHERE 
    cc.Pagada = 'NO' 
    AND c.EstatusCredito = 'VIGENTE' 
    AND UPPER(tg.NombreGarantia) = 'PRENDARIA';
GO