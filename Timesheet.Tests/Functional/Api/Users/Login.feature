Feature: In order to access the system, as a user, I must have access rights

Scenario: As an unauthorized user, I can not login to the system
Given the user is not registered in the system
When the user access the "users/login" api
Then the system must reply with error 404

Scenario: As an authorized user, I can login to the system

