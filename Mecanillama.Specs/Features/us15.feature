Feature: us15
Mecanillama backend

	@mytag
	Scenario: Revisar lista de citas como mecánico
		Given the mechanic logs in
		When the mechanic sees his profile
		Then the mechanic can see all their appointments