Feature: Getting Tracks using REST API
	As a REST API user
	I want to query the tracks list
	So I can use the information

Scenario: Get tracks list
	Given I have the following sessions with tracks:
			| title      | tracks							 | 
			| Some Ms..  | Microsoft, SharePoint, SQL Server | 
			| Phone me	 | WP7, Mobile, Android				 |
			| The GWT	 | Java, Web						 |
			| Capybara   | Ruby, Web, Agile, User Experience |
			| TDD		 | Ruby, Developer Foundation		 |
			| The Office | Office, Security, Web			 |
	When  I get "tracks" as JSON 
	Then  I should get a response with tracks:
			| track 	 | count | 
			| Microsoft  | 1	 |
			| SharePoint | 1	 |
			| SQL Server | 1	 |
			| WP7		 | 1	 |
			| Mobile	 | 1	 |
			| Android	 | 1	 |
			| Java		 | 1	 |
			| Web		 | 3	 |
			| Ruby		 | 2	 |
			| Agile		 | 1	 |
			| Office	 | 1	 |
			| Security	 | 1	 |
			| User Experience	   | 1 |
			| Developer Foundation | 1 |
