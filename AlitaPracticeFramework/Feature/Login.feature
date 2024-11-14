# This is the Login.feature file

Feature: Login
  As a user, I want to log into the application so that I can use its features.

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    Then I should be redirected to the dashboard