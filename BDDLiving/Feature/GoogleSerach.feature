Feature: GoogleSerach

A short summary of the feature

Here we are testing search functionality

@mytag
Scenario Outline: Verify search functionality
	Given that i am on google home page	
	When i enter the search text <stext> in search box
	And press enter
	Then search results should be displayed as per entered text <stext>	

	Examples: 
	| stext   |
	| Testing |