Feature: TheWebGame
We just want to know, that the browser will show our game info

Scenario: Opening the game in the browser
    When I open the game in the browser
    Then I see a welcome message in the browser

Scenario: Sending a command from the browser
    Given I opened the game in the browser
    When I send the command "where am i"
    Then the browser shows "I am in the Loo"
