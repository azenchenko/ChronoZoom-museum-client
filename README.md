ChronoZoom-museum-client
========================

Client application for ChronoZoom for museums bundle. To use this application you need a published version of ChronoZoom's for museum version which is located [here](https://github.com/alex-zen/ChronoZoom-museum-deploy) or manually build it using source code from here [here](https://github.com/alex-zen/ChronoZoom-museum)




Usage
-----

* Install modern windows application:
 - Launch `CZMuseumClient.sln`
 - Run application to install it
* Run ChronoZoom's service locally using IIS (it's mandatory to run application using port __2000__):
  - Suppose you have published project from [here](https://github.com/alex-zen/ChronoZoom-museum) to `C:/CZ Museum` or downloaded [https://github.com/alex-zen/ChronoZoom-museum-deploy](https://github.com/alex-zen/ChronoZoom-museum-deploy) to `C:/CZ Museum`.
  - Open command prompt, change directory where IIS or IIS Express is installed. For instance `C:/Program Files (x86)/IIS Express`.
  - Run following command (port __2000__ is mandatory in this case!)
  ```
  issexpress.exe /path:"C:\CZ Museum" /port:2000
  ```
* Open installed application to see

Acknowledgements
----------
ChronoZoom is built and maintained by a growing community, with the support of:

* University of California Berkeley
* Moscow State University
* University of Washington
* Microsoft Research

License
----------
ChronoZoom is made available under the [Apache 2.0 license](blob/master/Source/LICENSE.TXT).

To contribute to the project, please sign a [Contributor's Agreement](http://www.outercurve.org/Participate#Contributing_to_a_project).

[![Outercurve Foundation](http://www.outercurve.org/Portals/0/Skins/CodePlex_NEW/images/footer-logo.jpg)](http://www.outercurve.org/)
