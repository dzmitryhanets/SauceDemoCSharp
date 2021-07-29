Feature: Item Page

Scenario: Redirect to Item page
	Given SauceDemo page is opened in browser
	When login as 'standardUser'
		And user selects item #'0' on Products page
	Then Item page is opened for 'Sauce Labs Backpack' item