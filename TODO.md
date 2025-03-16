-------------------------------------------------------------------------------------------

NB!: Det virker sgu at lave namespace om til noget andet, for at ungå krydsreferencer.

- Lav det eksisterende namspace navn om til folderens navn.
- Lav børnefolderner om til forældrefoderens navn men med en dot annotation og derefter børnefolderens navn.
  Eks: Assert
      Assert.Sdk
      Assert.Sdk.Exeptions

  Det skaber et bedre overblik i aside TOP i ventre side.
  
- Ting at huske på når du gør det:
  - Style: 
    - Lav et custom template der fjerner:
    - alle referencer til 'namespace' i artiklerne. 
    - beskrivelsen af 'namespace' i url hvor man navigerer hen, når man trykker på namespacet.

-------------------------------------------------------------------------------------------



- Overwrite Assert class names to 'Assert'

- Either disable namespace navlink and overwrite them, (Easy)
  OR
  write a postprocessor that will change the namespace name and set the children to the given namespace
  (Might not be worth it, or at least make sure it is before diving in to it "Så spørg for satan! -").

- Write a list of tags for conventional commits, to be used in future documentation (types and scopes).

- Write a code example in XML to show how it looks like in the documentation.

- Write a postprocessor that appends a text, with a link and some text, on how one adds a code example
  to the documentation. ( NB! It should be easy and fast to add a code example to the documentation,
  because it will be people who don't need the example (expert), that will know what to write).
  One do NOT want to traverse the src code to figure out where to write the given example.

- "How to" template:
  Step definitions.
  The curse of knowledge is real. People who will write "How to's" are already in the game and will make assumptions
  on behave of the readers, that most likely will be new to the topic.

- Copy existing content over.

- Style (global):
  Remove class names and namespaces from the articles ?
  Rearrange property type and value to linear ?
  Remove inheritance ?
  Remove more in the top of the articles ?
