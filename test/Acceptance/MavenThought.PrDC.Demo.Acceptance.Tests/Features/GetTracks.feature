Feature: Getting Tracks using REST API
	As a REST API user
	I want to query the tracks list
	So I see the sessions per track

Scenario: Get tracks list
	Given I'm on the "tracks" page
	Then  I should see the following tracks with sessions
			| track 			   | count | sessions |
			| SharePoint 		   | 1	   | Ms a     |
			| WP7		 		   | 1	   | Ms a     |
			| Mobile	 		   | 1	   | Ms a     |
			| Android	 		   | 1	   | Ms a     |
			| Java		 		   | 1	   | Ms a     |
			| Ruby		 		   | 2	   | Ms a     |
			| Agile		 		   | 1	   | Ms a     |
