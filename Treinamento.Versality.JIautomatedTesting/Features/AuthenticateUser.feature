@AuthenticateUser
Feature: 02) Authenticate User
As a user i wnant to authenticate to the system to perform account management
Following the Following restrictions:
1) The email and the password fiels must be validated.
2) Only the user who informs the correct data for authentication must access the system.

Background: Acess the login page 
	Given that the user wants to authenticate 

Scenario Outline: 01) Validate mandatory fields
	And that the user enter the necessary data for authentication "<email>" "<password>"
	Then the user is informed that mandatory fields have not been filled out <"email"> <"password">
	Examples: 
	| email                  | password |
	|                        |          |
	|                        | 123456   |
	| test@naocadastrado.com |          |
	
Scenario: 02) Validate Invalid Login
	And that the user inform necessary data for authentication
		| email                 | passoword |
		| test@invalidlogin.com | 123456    |
	Then the user is informed that authentication has not been carried out

Scenario: 03) Log in
	And that  the user inform the necessay data for authentication
	Then the user is informed that the authentication was sucessful