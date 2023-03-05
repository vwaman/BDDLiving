Feature: Login

A short summary of the feature

@tag1
Scenario: Login into the application
	Given they are on the login page
	And they enter correct username and password
	When click on login button
	Then they see the account page
	And they see the name in the right top


Scenario: Customer buys Guava
	Given they are on fruit stall
	And they select Guava
	When they paid "68p"
	Then they able to buy the Guava successfully


Scenario Outline: Customer buys fruits on different days
    Given they are on fruit stall
    And the customer buys the following fruits on <day>:
          | fruitItem   | quantity   | pricePerItem   |
          | <fruitItem> | <quantity> | <pricePerItem> |
    When  they make <total> payment
    Then  they able to buy fruit sucessfully
    Examples:
      | day            | fruitItem | quantity | pricePerItem | total |
      | Day 1          | Guava     | 1        | 20           | 20    |
      | Following Day  | Guava     | 2        | 25           | 50    |
      | Following Day  | Orange    | 1        | 35           | 35    |
      | Two days later | Guava     | 1        | 35           | 35    |
      | Two days later | Orange    | 2        | 30           | 60    |


Scenario Outline: An employee purchases foods using credit card from food court
    Given the employee purchases the following foods on <day>:
          | foodItem   | quantity   | pricePerItem   |
          | <foodItem> | <quantity> | <pricePerItem> |
    When  they make <total> payment using credit card
    Then  they see transaction <status>
    Examples:
      | day   | foodItem                 | quantity | pricePerItem | total | status                      |
      | Day 1 | Pizza                    | 10       | 5.5          | 50.5  | Transaction is successful   |
      | Day 1 | Popcorn                  | 6        | 1            | 6     | Transaction is successful   |
      | Day 2 | Chicken burgers and coke | 8        | 6            | 48    | Transaction is successful   |
      | Day 3 | Pav Bhaji                | 7        | 4            | 28    | Transaction is unsuccessful |
      

Scenario: Customer buys items from FlipKart and pay through PayTM account
    Given the customer have £100.00 in PayTM account
    And   the customer logged in with valid credentials
    And   they add the below items into cart on day 1:
      | ItemName           | Price |
      | Pro Kabbaddi shirt | £15   |
    And   they make payment "£15" through PayTM account
    And   the order placed successfully
	And   the balance in PayTM account is "£85.00"
	And   they add the below items into cart on day 2:
      | ItemName                      | Price |
      | Signed music CD of A R Rehman | £45   |
      | Signed music CD of Pritam     | £35   |
    And   they make payment "£80" through PayTM account
    And   the order placed successfully
	And   the balance in PayTM account is "£5.00"
	And   they add the below items into cart on day 3:
      | ItemName            | Price |
      | Bluetooth headphone | £32   |
    And   they make payment "£32" through PayTM account
    And   the order is not placed successfully due to insufficient fund
    And   on day four, they add "£30.00" into PayTM account wallet
	And   the balance in PayTM account is "£35.00"
    And   they add the below items into cart on day 4:
      | ItemName            | Price |
      | Bluetooth headphone | £32   |
    When  they make payment "£32" through PayTM account
    Then  the order placed successfully
	And   the balance in PayTM account is "£3.00"

