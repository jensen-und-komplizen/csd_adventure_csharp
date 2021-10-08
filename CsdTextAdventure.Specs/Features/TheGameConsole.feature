Feature: TheGameConsole
We just want to know, that the console will read and write our game info

Scenario: Running a new game
    When I start the console game
    Then I see a welcome message on the console