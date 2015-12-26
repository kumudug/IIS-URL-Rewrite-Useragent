# IIS-URL-Rewrite-Useragent
URL rewrite in IIS after checking user agent.

##  The problem

I was creating an AngularJS application for a client when I hit a roadblock. The project needed the ability to support fabebook Open Graph properties, pinterest rich pins, stumble upon links, google plus links. All the above were failing. 

## The reason

All the above mentioned crawlers do not execute javascript. So I was stuck in a rock and a hard place. :(. So the soution I designed was to do a url rewrite for all the requests coming from the above said crawlers to a page generated using PhantomJS. Simple right? but wait. Since I already had html5 type url rewrites set up etc it was pretty cumbersome to write al the URL rewrite logic for IIS. At one point I was not sure how the user agent strings actually looked like. So this project was born.

## Purpose

This project is going to help me understand the user agent string that is used by the above mentioned crawlers and how to do url rewrites for them. 
