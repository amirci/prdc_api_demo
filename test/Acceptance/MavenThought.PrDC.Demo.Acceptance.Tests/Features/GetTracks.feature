Feature: Getting Tracks using REST API
	As a REST API user
	I want to query the tracks list
	So I see the sessions per track

Scenario: Get tracks list
	Given I'm on the "tracks" page
	Then  I should see the following tracks with sessions
			| track 			   | count | 
			| SharePoint 		   | 3	   | 
			| WP7		 		   | 3	   | 
			| Mobile	 		   | 7	   | 
			| Android	 		   | 3	   | 
			| Java		 		   | 7	   | 
			| Ruby		 		   | 1	   | 
			| Agile		 		   | 7	   | 
