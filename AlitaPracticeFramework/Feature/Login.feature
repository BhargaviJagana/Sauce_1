# Login.feature

Feature: Login Functionality

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    Then I should be redirected to the dashboard

  Scenario: Unsuccessful Login
    Given I am on the login page
    When I enter invalid credentials
    Then I should see an error message