Feature: Login To Application

Background: 
	Given SauceDemo page is opened in browser

Scenario: Login as problem user
	When login as 'troubleUser'
	Then error message 'Epic sadface: Sorry, this user has been locked out.' appears

Scenario: Login as standard user
	When login as 'standardUser'
	Then page title is 'PRODUCTS'