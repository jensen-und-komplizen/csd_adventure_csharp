Feature: TheBeginning
	We just want to know, what we are getting into, when we start playing the game

Scenario: Starting an adventure
	When I start the adventure
	Then I see a welcome message
	
Scenario: Moving from the Loo to the restroom if pants up
	Given I started the adventure
	And I am in the Loo
	When I pull up pants 
	When I go through the door
	Then I am in the Restroom

Scenario: Moving from the Loo to the restroom if pants down
	Given I started the adventure
	And I am in the Loo
	When I go through the door
	Then I must pull my pants up
	
