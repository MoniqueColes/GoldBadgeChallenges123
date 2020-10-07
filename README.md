# GoldBadgeChallenges123

My Folders are labeled as KomodoCafe, KomodoClaims and KomodoInsurance.

Komodo Cafe
Komodo cafe is getting a new menu. The manager wants to be able to create new menu items, delete menu items, and receive a list of all items on the cafe's menu. She needs a console app.

The Menu Items:
A meal number, so customers can say "I'll have the #5"
A meal name
A description
A list of ingredients,
A price

I have:
Created a Menu Class with properties, constructors, and fields.
Created a MenuRepository Class that has methods needed.
Created a Test Class for repository methods. 
Created a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
I did not allow for items to be updated because it was not required.


Komodo Claims Department
Komodo has a bug in its software and needs some new code.

The Claim has the following properties:
ClaimID
ClaimType
Description
ClaimAmount
DateOfIncident
DateOfClaim
IsValid
Komodo allows an insurance claim to be made up to 30 days after an incident took place. If the claim is not in the proper time limit, it is not valid.

A ClaimType example:
Car
Home
Theft
 
The app has methods to do the following:
Show a claims agent a menu:
Choose a menu item:
1. See all claims
2. Take care of next claim
3. Enter a new claim
 
I have done the following:
1. Created a Claim class with properties, constructors, and any necessary fields.
2. Created a ClaimRepository class that has proper methods.
3. Created a Test Class for your repository methods.
4. Created a Program file that allows a claims manager to manage items in a list of claims.


Challenge 3: Badges
Komodo Insurance
Komodo Insurance is fixing their badging system.

Here's what they need:
An app that maintains a dictionary of details about employee badge information.

Essentially, a badge will have a badge number that gives access to a specific list of doors. For instance, a developer might have access to Door A1 & A5. A claims agent might have access to B2 & B4.

I have created the following:
A badge class that has the following properties:
BadgeID
List of door names for access
A badge repository that will have methods that do the following:
Create a dictionary of badges.
The key for the dictionary will be the BadgeID.
The value for the dictionary will be the List of Door Names.
 
The Program will allow a security staff member to do the following:
create a new badge
update doors on an existing badge.
delete all doors from an existing badge.
show a list with all badge numbers and door access.

I did not need to consider tying an individual badge to a particular user. Just the Badge # will do.
