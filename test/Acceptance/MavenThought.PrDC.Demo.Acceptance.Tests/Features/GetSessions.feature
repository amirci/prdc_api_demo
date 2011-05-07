Feature: Getting sessions using REST API
	As a REST API user
	I want to query the session list
	So I can use the information

Scenario: Getting all the sessions in the conference
	Given I have some sessions at the conference 
	When  I get "sessions" as JSON 
	Then  I should get a response with all the sessions

Scenario: Getting all the sessions for the Agile track
	Given I have some sessions at the conference 
	And   I have track "Agile" with sessions:
			| Title					 | Presenter      |
			| How agile is your Cat? | Sir Elton Jhon |
			| Agile pants			 | D'Arcy Lussier |
	When  I get "sessions/Agile" as JSON 
	Then  I should get a response with:
			| Title					 | Presenter      | Track |
			| How agile is your Cat? | Sir Elton Jhon | Agile |
			| Agile pants			 | D'Arcy Lussier | Agile |
