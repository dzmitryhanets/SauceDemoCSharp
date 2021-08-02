Feature: Item Page

Background: 
	Given SauceDemo page is opened in browser
	When login as 'standardUser'

Scenario: Redirect to Item page
	When user selects item #'0' on Products page
	Then Item page is opened for 'Sauce Labs Backpack' item