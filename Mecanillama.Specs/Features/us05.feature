Feature: us05
Mecanillama backend

    @mytag
    Scenario: Publicacion de reseña acerca del taller mecánico
        Given the customer is at the homepage
        When the customer visits a mechanic profile
        And clicks the review text box
        Then the customer can type the comment
        And select the amount of stars
        Then the review should appear