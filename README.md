# ArchitectureExperiment
This is a experiment with MVVM pattern primarily for any Graphical User Interface applications including webapps.
I will experimenting with WPF and C# since it's my primary tool of interest.

# Problem Trying to Solve
In one sentence: **Make finding all components of a given Graphical User Interface very simple.**

Imagin starting a new job at a company as a developer.
In the first week you become slowly familiar with the defined project structure.
You get some workloads for fixing bugs and implementing feature requests.
The deeper you get into the project, chances become higher to meet some project structure violances.
Then you start looking for obvious strings from the Graphical User Interface by your default search-engine built into Visual Studio.
When you're lucky, you find exactly one spot in the entire solution and know, where you have to make your changes to get the job done.
That's frustrating and leads knowledge to be encapsulated by single developers who did this mess.

# Possible Solution to Experiment With
In one sentence: **Introducing in the presentation layer a second project structure in form of a visual tree implemented by symbolic links.**

Therefore I got an idea how to make finding the right files for obvious changes in the Graphical User Interface straight forward.
Imagin having two project structures implemented by Visual Studio solution at the same time, which do not disturb each other.

The classic way to lay out a MVVM pattern is by creating folders in projects which results in a project/folder tree.
I name this traditional way a logical tree. Since it separates the application in logical modules, which technicaly is a big plus.
Adding to this a visual tree in form of having symbolic links to files, that belong to the specific Graphical User Interface
could do the trick.

After some brainstorming I located, that the mess starts and ends on the Graphical User Interface side.
Since this is in many programs the point, where every technical peace clashes together 
with the goal of making a program interacting with users.

It's importend that the visual tree consist largely by symbolic links due to having only one single point of maintaining the same file.
Also it is much easier to track a program while execution by focusing on the Graphical User Interface.

For example:
Workload is to implement a second textfield for the 2nd first name in the window where a new user can be created.
With this concept it could be theoretical possible to find all files that have to be changed by following steps:
1. Start program
2. Navigate to window for user creation
3. Understand in which Graphical User Interface component you are currently in by buzz-words like "user creation", "create new user", ..
4. Take a look at the presentation layer in Visual Studio
4.1 You see a folder named "Views"
4.2 You see a sub-folder named "Users"
4.3 You see a sub-folder names "Creation"
4.4 Now you're clearly on the right way to get the juicy files
5. Finaly you see in this last folder all files, that interact with this window like:
* User_BusinessObject.cs
* User_Model.cs
* CreateUser_ViewModel.cs
* User_Commands.cs
* CreateUser_PartialView.xaml
* CreateUser_PartialView.xaml.cs
* UserStyles_Resources.xaml
* EmailTextBox_UserControl.xaml
* EmailTextBox_UserControl.xaml.cs

On paper this approach sound pretty usefull and timesaving - especially for junior developers and project hoppers.
This project is all about to test this idea, if it would be practical to have everything what interacts together
on a single spot which can be easely found by following the running program logicaly.

Assumed that this concept could work well, the next issue to solve will be **automating this approach by a crawler program** or simillar. 
Since people are tending to inconsistency and lazyness over time.

Any help, discussion, ideas, critics, feedback and so on are welcome. :)

Sincerly,

Robert Jaśkowski
