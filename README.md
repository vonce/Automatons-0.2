# Automatons, Unity Game
### Summary

A unity game not yet complete where the idea of the game is to design logic for your units and have them automatically fight against an opponent's robots. The winner would be the better designed logic for the robots. A robot "brain" would be at most 5 logic "gates". A gate would be comprised of 3 main parts. First a condition to be fulfilled. These were things such as "Always" or "if self health less than" or "if nearest enemy health less than".  Then an action. These would be things like "attack" or "special" or "move to". The last part of a gate was a target. These would just be a target for the chosen action. If the condition cannot be fulfilled, the robot moves onto the next gate in the priority list. For example, a simple robot would given gates of
condition(if self health less than 30%) action (move to) target (ally base)
condition(always) action (attack) target (nearest enemy)
condition(always) action (attack) target (enemy base)

This robot would first check if its health is below 30 percent. if it is, it checks to see if the action is possible. If it is possible, it executes the action. If health is above 30, it moves to the next gate. It automatically fulfills the condition because of the "always" condition and moves on to check if the action is possible. If there are no enemies nearby, it will go on to next gate, and attack the enemy base, which is every robot's default last priority gate.
