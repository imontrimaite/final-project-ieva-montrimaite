# Final Project
## Test cases
Site link: https://www.topocentras.lt/

- **Test scenario: Check new user registration functionality**
  - **Test case 1** - Check if user is able to register with valid registration details
    <p> Steps: </p>
    <p> 1. Enter valid email address </p>
    <p> 2. Enter valid password </p>
    <p> 3. Check both checkboxes (to agree to be a TOPO CLUB member and not to aggree to receive personalized offers) </p>
    <p> 4. Click register button </p>
    <p> 5. Check if confirmation message appears upon successful registration ("Nurodytu el.paštu išsiuntėmė laišką registracijos patvirtinimui.") </p>
     
  - **Test case 2** - Check if user is not able to register with invalid password
    <p> Steps: </p>
    <p> 1. Enter valid email address </p>
    <p> 2. Enter invalid password (less than 6 characters long ("Test")) </p>
    <p> 3. Click register button </p>
    <p> 4. Check if error message appears ("Slaptažodį turi sudaryti ne mažiau kaip 6 simboliai. Minimalus skirtingų simbolių klasių kiekis slaptažodyje: 4. Simbolių klasės: mažosios raidės, didžiosios raidės, skaitmenys, specialieji simboliai (~!@#$%^&*()_+[]\;’,./{}|:”<>?).") </p>
    <p> 5. Remove previous password </p>
    <p> 6. Repete the previous steps each time using a different password that doesn't meet valid password requirements("testpassword?1", "Testpassword?", "Testpassword1", "TESTPWRD?1") </p>
    
- **Test scenario: Check add to cart functionality**
  - **Test case 3** - Check if user is able to add products to cart from the different pages and increase product quantity
    <p> Steps: </p>
    <p> 1. Click add to cart button in the category page (product: HUAWEI Nova 8i Starry Black) </p>
    <p> 2. In the popup window click continue shopping button </p>
    <p> 3. Click on the product (product: APPLE iPhone 13 mini 512GB (PRODUCT)RED) </p>
    <p> 4. In the product page click add to cart button </p>
    <p> 5. In the popup window click continue shopping button </p>
    <p> 6. Hover on cart button in the top right of the page </p>
    <p> 7. Click on buy button </p>
    <p> 8. Click on quantity plus sign to increase product quantity (product: HUAWEI Nova 8i Starry Black) </p>
    <p> 9. Check if selected products are present in the cart </p>
    <p> 10. Check if product quantity has been updated </p>
    
- **Test scenario: Check product comparison functionality**
  - **Test case 4** - Check if user is able to get differences of selected products
    <p> Steps: </p>
    <p> 1. Check comapre option under the product APPLE MacBook Pro 14" M2 Pro 10C </p>
    <p> 2. Check comapre option under the product APPLE MacBook Pro 14" M2 Max 12C CPU </p>
    <p> 3. Click compare button </p>
    <p> 4. In the new page select "Show only differences between compared products" </p>
    <p> 5. Check if color information is different </p>
    <p> 6. Check if item code information is different </p>
    <p> 7. Check if manufacturer code information is different </p>
    
- **Test scenario: Check product filter functionality**
  - **Test case 5** - Check if user is able to filter products by price and manufacturer
    <p> Steps: </p>
    <p> 1. Select price up to 300 eur within the price range filter </p>
    <p> 2. Select PHILIPS within the manufacturer filter </p>
    <p> 3. Check if all filtered products cost less than 300 eur </p>
    <p> 4. Check if all selected products are PHILIPS TV </p>
