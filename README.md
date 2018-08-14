# Kickr fork
This project is used in the [Build an augmented reality app on Root insurance](https://make.offerzen.com/course/root-insurance-augmented-reality) course, at [Make by OfferZen](https://make.offerzen.com/).

You can see the original sample [here](https://github.com/OfferZen-Make/arinsuretech-kicker.git).

## Intent
When a user introduces Cozmo's cube to the scene, an insurance quote should pop up, giving the opportunity to insure the precious cube against theft or damage for x per month.

If the user chooses to accept the offer, then
1. A policy holder is created
2. An application is made using the `quote ID` and the `policy ID`
3. The policy is issued

The cube should have buttons on its faces that can be activated by a person (or by Cozmo). If a button is pressed or the cube disappears from the screen, a dialog should appear to either
 - Offer the opportunity to claim for the loss, or
 - Say "too bad, not insured"

## Achieved
 - Cube detection
 - Virtual buttons
 - Quote generation

## Issues
 - The cube can only be insured as a device (i.e. cell phone).
 - Virtual buttons on a multi-target image (i.e. cube) does not seem to be well supported.
 - Holding the async results in memory from the quote is tricky (lacking the C# skills)
