Feature: us04
Mecanillama backend

	@mytag
	Scenario: Leer reseñas del taller
		Given the customer is at the homepage
		When the customer visits a mechanic profile
		Then the customer can see the mechanic's reviews