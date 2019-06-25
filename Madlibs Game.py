# Init Variables
theMatrix = ""
system = ""
neo = ""
enemy = ""
inside = ""
save = ""
unplugged = ""
fight = ""
profession = ["","","",""] 
adj = ["",""]

# Get Input From User
print("Welcome, player!")
print("Lets play a game of madlibs!")
# Gets neo variable from user
neo = input("Please tell me your name\n") 

# Gets theMatrix variable from user
print(f"Hello {neo}! Are you ready?") 
theMatrix = input("What is something you want to know more about?\n") 

# Gets system variable from user
print(f"Oh, you want to know more about the {theMatrix}? ")
print(f"Ok. First tell me what you already know about the {theMatrix}.")
system = input(f"What noun would you categorise the {theMatrix} as?\n") 

# Gets enemy variable from user
enemy = input(f"Give me an opposing noun to {system}!\n") 

# Gets inside variable from user
inside = input(f"Now give me a noun to describe where someone is (present tense).\n") 

# Gets user to define each of the four professions needed
print(f"Okay, now I need four profession relating to {system}.")
for i in range(len(profession)):
    profession[i] = input(f"Profession (plural) {i + 1} / {len(profession)}.\n")

# Gets save variable from user
save = input("More questions. What would you do for the people in these professions?\n")

# Gets user to define unplugged variable
unplugged = input("What are these people not ready to be?\n")

# Gets user to define the two adjectives needed
print("Okay, now I need two adjectives relating to these people.")
for i in range(len(adj)):
    adj[i] = input(f"Adjective (plural) {i + 1} / {len(adj)}.\n")

# Gets user to define fight variable
fight = input(f"Okay, one more word. What would these people do to protect {theMatrix}?\n")

# Ending line
print("All done! Time to read your story, my dude or dudette.\n")

# Init Story
madlibsStory = (f"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}. " +
f"But when you're {inside}, you look around, what do you see? " +
f"{profession[0]}'s', {profession[1]}'s', {profession[2]}'s', {profession[3]}'s'. The very minds of " +
f"the people we are trying to {save}. But until we do, " +
f"these people are still a part of that {system} and that makes " +
f"them our {enemy}. You have to understand, most of these people " +
f"are not ready to be {unplugged}. And many of them are so {adj[0]}, " +
f"so hopelessly {adj[1]} on the system, that they will {fight} to protect it.")

# Print Story
print(madlibsStory) # Prints the story
