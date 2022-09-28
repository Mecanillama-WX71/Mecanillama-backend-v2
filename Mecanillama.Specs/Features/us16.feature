Feature: us16
Mecanillama backend

	@mytag
	Scenario: Registro de usuario
		Given the user is at the homepage
		When the user clicks Sign up
		Then the user can fill the form
		And click the Sign up button
		Then the user will be redirected to the main page