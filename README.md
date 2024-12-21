# Pokérole InitiativeTracker
[Pokérole](https://www.pokeroleproject.com) is an independent Pokémon TTRPG, and it's really good, but keeping track of whose turn it is during battles can get quite difficult, especially as you have to remember how many individual successes every Pokémon needs to do anything.
Enter the **Pokérole Initiative Tracker**!
## How to use the application:
1. Add all the Pokémon taking part by inputting their Name and Initiative (and optionally Dexterity if you need to break any ties) and pressing the **Add Pokémon** button. Pokémon will automatically be sorted into their initiative order in the view on the right. This view will show you the Pokemon's name, initiative, needed successes, and dexterity (if you put one in when adding it).
2. Click the **Start!** button to start the battle! The Pokémon whose turn it is will have their name displayed in big letters on the bottom of the screen, and their name will be highlighted in the view on the right.
3. Play that Pokémon's turn! If that Pokémon uses an action, you can press the **Use Action** button to increase the amount of successes needed for that Pokémon going forward. If a Pokémon gets knocked out you can double click the poor creature in the list on the right to select it and click the **Faint** button to remove it from the initiative order. If another Pokémon attempts to clash, evade, or use a priority move, you can select that Pokémon by double clicking it and increase its needed successes as well!
4. Move on to the next turn! Hit the **Next Turn** button and watch the highlighted Pokémon change to the next one in the initiative order.
5. When you're ready, move on to the next round. When you've finished rerolling everybody's initiative, you can update everyone's initiative by double clicking them on the right, putting in their new numbers on the left, and hitting the **Update Pokémon** button (You can also update Pokémon stats at any other time). Then, when everyone is updated, hit the **New Round** button to reset everybody's needed successes back to 1.
6. Repeat until your battle is finished!

### Notes and to-do:
- There is a Pokémon move called Trick-Room which effectively reverses the turn order. There is currently no implementation for this, one is in the works.
- Highlighting can disappear temporarily when selecting or editing Pokémon outside of their turn. 
