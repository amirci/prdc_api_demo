Feature: List Presenters using REST API
	As a user
	I want to query the presenters list

@presenters
Scenario: List presenters
	Given I'm on the "speakers" page
	Then  I should see the following presenters:
			| D'Arcy Lussier |
			| David Alpert   |
			| Amir Barylko   |
			| Donald Belcham |



