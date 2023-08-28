CREATE PROCEDURE [dbo].[CSP_GetTaches]
AS
BEGIN
	SELECT Id, Titre, Finalise FROM Tache;
	RETURN 0;
END