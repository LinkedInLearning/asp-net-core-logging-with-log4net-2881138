# ASP.NET Core: Logging with Log4Net
This is the repository for the LinkedIn Learning course ASP.NET Core: Logging with Log4Net. The full course is available from [LinkedIn Learning][lil-course-url].

![ASP.NET Core: Logging with Log4Net][lil-thumbnail-url] 
Logging frameworks like log4net can help standardize and streamline the process of event logging: helping developers control which events are output and where to output them. This course teaches a real-world, project-based approach to event logging for ASP.NET Core applications with log4net. Instructor Ervis Trupja explains the benefits of using a logging framework and the options available to you. He then shows how to set up the log4net framework for console, web API and MVC apps, and how to log to different mediums: a regular log file, a rolling file, and a SQL database. Plus, learn how to create a custom exception handler and configure it in the middleware to log exceptions globally.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


### Instructor

**Ervis Trupja**

_Full-Stack .NET Web Developer with a mathematical background_

Check out some of my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/ervis-trupja).

[lil-course-url]: https://www.linkedin.com/learning/asp-dot-net-core-logging-with-log4net
[lil-thumbnail-url]: https://cdn.lynda.com/course/2881138/2881138-1620938355577-16x9.jpg
