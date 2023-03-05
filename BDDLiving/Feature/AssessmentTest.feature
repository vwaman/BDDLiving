Feature: AssessmentTest

Scenario: Customer buys an orange
	Given they are on fruit stall
	And   they select an orange
	When  they paid "35p"
	Then  they buy an orange successfully

Scenario Outline: Customer buys fruits on different days
    Given they are on fruit stall
    And   the customer buys the following fruits on <day>:
          | fruitItem   | quantity   | pricePerItem   |
          | <fruitItem> | <quantity> | <pricePerItem> |
    When  they make <total> payment
    Then  they able to buy fruit successfully
    Examples:
      | day            | fruitItem | quantity | pricePerItem | total |
      | Day 1          | orange    | 1        | 20           | 20    |
      | Following Day  | orange    | 2        | 25           | 50    |
      | Following Day  | apple     | 1        | 35           | 35    |
      | Two days later | orange    | 1        | 35           | 35    |
      | Two days later | apple     | 2        | 30           | 60    |

Scenario Outline: Customer purchases some items using credit card from supermarket
    Given the <customer> purchases the following items on <day>:
          | foodItem   | quantity   | pricePerItem   |
          | <foodItem> | <quantity> | <pricePerItem> |
    When they make <total> payment using credit card
    Then they see transaction <status>
    Examples:
      |customer | day   | foodItem          | quantity | pricePerItem | total | status                      |
      |customer1| Day 1 | Pizza             | 9        | 4.75         | 42.75 | Transaction is successful   |
      |customer1| Day 1 | Tubs of ice cream | 5        | 1.45         | 7.25  | Transaction is successful   |
      |customer2| Day 1 | Sandwiches        | 2        | 3.5          | 7     | Transaction is declined     |
      |customer1| Day 2 | Chickens          | 7        | 6.99         | 48.93 | Transaction is successful   |
      |customer1| Day 2 | Drinks            | 2        | 0.53         | 1.06  |  Transaction is declined    |

Scenario: Customer withdraw cash from bank account
    Given the customer have £500.00 in bank account
    And they withdraw "£75" cash through bank account
    And they withdraw the cash successfully
	And the balance in bank account is "£425"
    And they withdraw "£200" cash through bank account
    And they withdraw the cash successfully
	And the balance in bank account is "£225"
    When they withdraw "£50" cash through bank account
    Then they withdraw the cash successfully
	And the balance in bank account is "£175"