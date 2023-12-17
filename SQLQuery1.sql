INSERT INTO dbo.Disasters (
    Name, 
    Type, 
    Scope, 
    DateStarted, 
    DateEnded, 
    EpicenterId, 
    Description, 
    AffectedAreas, 
    IsActive, 
    ImpactLevel, 
    InitiatingEvent, 
    ReliefResources, 
    ImmediateNeeds, 
    EstimatedAffectedPopulation, 
    EstimatedCasualties, 
    EstimatedDisplacedPersons, 
    EstimatedEconomicLoss, 
    DisasterType, 
    Magnitude, 
    Depth, 
    FloodedArea, 
    BurnedArea
) VALUES (
    'Nome do Desastre', -- Name NVARCHAR(250)
    1,                  -- Type INT
    1,                  -- Scope INT
    '2023-01-01',       -- DateStarted DATETIME2(7)
    '2023-01-02',       -- DateEnded DATETIME2(7)
    NULL,               -- EpicenterId INT (NULL se não disponível)
    'Descrição do Desastre', -- Description NVARCHAR(2000)
    'Áreas Afetadas',   -- AffectedAreas NVARCHAR(MAX)
    1,                  -- IsActive BIT (0 para falso, 1 para verdadeiro)
    'Nível de Impacto', -- ImpactLevel NVARCHAR(MAX)
    'Evento Inicial',   -- InitiatingEvent NVARCHAR(250)
    'Recursos de Socorro', -- ReliefResources NVARCHAR(MAX)
    'Necessidades Imediatas', -- ImmediateNeeds NVARCHAR(MAX)
    1000,               -- EstimatedAffectedPopulation INT
    100,                -- EstimatedCasualties INT
    500,                -- EstimatedDisplacedPersons INT
    1000000.00,         -- EstimatedEconomicLoss DECIMAL(18, 2)
    'Tipo de Desastre', -- DisasterType NVARCHAR(MAX)
    5.5,                -- Magnitude FLOAT(53) (NULL se não disponível)
    NULL,               -- Depth FLOAT(53) (NULL se não disponível)
    NULL,               -- FloodedArea FLOAT(53) (NULL se não disponível)
    NULL                -- BurnedArea DECIMAL(18, 2) (NULL se não disponível)
);
