-- ==============================================================================
-- EVALUACIÓN - Punto 1: Script de creación de base de datos, tablas y consulta
-- ==============================================================================

-- 1. CREACIÓN DE LA BASE DE DATOS
USE master;
GO

-- (Opcional) Elimina la BD si ya existe para evitar errores al ejecutar el script varias veces
IF DB_ID('EvaluacionCodesarrollo') IS NOT NULL
BEGIN
    ALTER DATABASE EvaluacionCodesarrollo SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EvaluacionCodesarrollo;
END
GO

CREATE DATABASE EvaluacionCodesarrollo;
GO

USE EvaluacionCodesarrollo;
GO

-- ------------------------------------------------------------------------------
-- 2. DEFINICIÓN DE TABLAS (DDL)
-- ------------------------------------------------------------------------------

-- Tabla: Tipo de garantías
CREATE TABLE Tipo_Garantia (
    IdTipoGarantia INT PRIMARY KEY,
    NombreGarantia VARCHAR(50) 
);

-- Tabla: Crédito
CREATE TABLE Credito (
    NumeroCredito INT,
    Sucursal INT,
    EstatusCredito VARCHAR(20), 
    IdTipoGarantia INT,
    PRIMARY KEY (NumeroCredito, Sucursal),
    FOREIGN KEY (IdTipoGarantia) REFERENCES Tipo_Garantia(IdTipoGarantia)
);

-- Tabla: Cuota crédito
CREATE TABLE Cuota_Credito (
    NumeroCredito INT,
    Sucursal INT,
    NumeroCuota INT,
    FechaVencimiento DATE,
    Capital DECIMAL(18, 2),
    Interes DECIMAL(18, 2),
    Mora DECIMAL(18, 2),
    Pagada VARCHAR(2), 
    PRIMARY KEY (NumeroCredito, Sucursal, NumeroCuota),
    FOREIGN KEY (NumeroCredito, Sucursal) REFERENCES Credito(NumeroCredito, Sucursal)
);
GO