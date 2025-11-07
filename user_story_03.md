User Story: Reset Application State to Clear Cart
ID: TC-003 Title: Resetting App State After Adding Items to Cart

As a: user of saucedemo.com who has changed their mind I want to: add multiple items to my cart and then use the "Reset App State" feature So that I can: quickly clear my cart and start my shopping session over from a clean state.

Acceptance Criteria
Given I am on the login page at https://www.saucedemo.com.
When I enter the username standard_user into the input field with id="user-name".
And I enter the password secret_sauce into the input field with id="password".
And I click the login button with id="login-button".
Then I should be on the inventory page.
When I click the "Add to cart" button for the "Sauce Labs Backpack" (id="add-to-cart-sauce-labs-backpack").
And I click the "Add to cart" button for the "Sauce Labs Bike Light" (id="add-to-cart-sauce-labs-bike-light").
Then the shopping cart badge should display the number 2.
When I click the burger menu button with id="react-burger-menu-btn".
And I click the "Reset App State" link, which has the id="reset_sidebar_link".
Then the shopping cart badge should no longer be visible.
When I go to the shopping cart page by clicking the cart icon (id="shopping_cart_container").
Then the cart should be empty.
