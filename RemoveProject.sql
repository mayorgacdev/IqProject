ALTER PROCEDURE RemoveProject @projectId int 
AS 
BEGIN
     DELETE FROM Asset WHERE ProjectId = @projectId
	 DELETE FROM InvesmentArea WHERE ProjectId = @projectId
	 DELETE FROM ProjectEntry WHERE ProjectId = @projectId
	 DELETE FROM ProjectCost WHERE ProjectId = @projectId
	 DELETE FROM InvestmentEntity WHERE ProjectId = @projectId
	 DELETE FROM ProjectExpense WHERE ProjectId = @projectId
     DELETE FROM Project WHERE Id = @projectId

END
