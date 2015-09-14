CREATE PROCEDURE LeverancierWijzigen
	@oudLevNr int,
	@nieuwLevNr int
AS
	update Planten set Levnr = @nieuwLevNr where Levnr = @oudLevNr