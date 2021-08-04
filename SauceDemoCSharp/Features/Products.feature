Feature: Products
	
Background: 
	Given SauceDemo page is opened in browser
	When login as 'standardUser'

Scenario: Button title is changed from 'Add To Cart' to 'Remove'
	When user clicks inventory button for item #'1'
	Then button title for item #'1' is changed to 'REMOVE'

Scenario: Button title is changed from 'Remove' to 'Add To Cart'
	When user clicks inventory button for item #'1'
		And user clicks inventory button for item #'1'
	Then button title for item #'1' is changed to 'ADD TO CART'