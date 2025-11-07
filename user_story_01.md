User Story: Manage Cart by Removing an Item
ID: TC-002 Title: Add and Remove Item from Cart

As a: registered user of saucedemo.com I want to: add a product to my shopping cart and subsequently remove it So that I can: ensure my cart accurately reflects my final purchase decisions.

Acceptance Criteria
Given I am on the login page at https://www.saucedemo.com.
When I enter the username standard_user into the input field with id="user-name".
And I enter the password secret_sauce into the input field with id="password".
And I click the login button with id="login-button".
Then I should be redirected to the inventory page, which has the URL path /inventory.html.
When I locate the item named "Sauce Labs Backpack".
And I click the corresponding "Add to cart" button, which has the id="add-to-cart-sauce-labs-backpack".
And I click the shopping cart container, which has the id="shopping_cart_container".
Then I should be on the cart page, which has the URL path /cart.html.
And the "Sauce Labs Backpack" should be visible in the cart.
When I click the "Remove" button for the "Sauce Labs Backpack", which has the id="remove-sauce-labs-backpack".
Then the shopping cart should be empty.
When I click the "Continue Shopping" button with id="continue-shopping".
Then I should be returned to the inventory page.
