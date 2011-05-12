Feature: List sessions using REST API
	As a user
	I want to query the sessions list

@sessions
Scenario: List all the sessions
	Given I'm on the "sessions" page
	Then  I should see the following sessions:
			| Self Organizing Teams    |
			| A Dash of Kanban Anyone? |
			| Want Better Estimates? Stop Estimating!  |
			| Agile Fishbowl |



