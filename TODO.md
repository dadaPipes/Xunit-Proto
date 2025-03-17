-------------------------------------------------------------------------------------------
ker sgu at lave namespace om til noget andet, for at ungå krydsreferencer.

  - Style: 
    - Lav et custom template der fjerner:
    - alle referencer til 'namespace' i artiklerne. 
    - beskrivelsen af 'namespace' i url hvor man navigerer hen, når man trykker på namespacet.


public class AssertEquivalenceComparer : IEqualityComparer
AND
public class AssertEquivalenceComparer<T> : IEqualityComparer<T>
(Both classes are in the same file.)

They are under the namespace 'Xunit, but in the Xunit.Sdk folder !?!?!

-------------------------------------------------------------------------------------------

- Write a code example in XML to show how it looks like in the documentation.


- Overwrite Assert class names to 'Assert': Virker fucking ikke.. sletter det hele

- Write a list of tags for conventional commits, to be used in future documentation (types and scopes).

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
