Feature: us14
	Mecanillama backend

@mytag
Scenario: Registro de cita
	Given the customer is at the homepage
	When the customer visits a mechanic profile
	And clicks the make an appointment button
	Then the customer can select the required data
	And the appointment should be at the Appointments tab