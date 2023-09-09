# Lane-Change-Test
This is a Unity-based version of the Lane Change Test, designed for improved portability and ease of configuration, allowing for customization as needed. It adheres to the standards established by the previously created Lane Change Test.

This project is built upon the LCT, which is a driving test used to measure and compare a driver's actual route to the perfect route. In this test, the driver must follow instructions provided by signs appearing on both sides of the road. This software serves to eliminate the need for conducting tests with real vehicles, thereby preventing accidents and vehicle repair costs.

During the tests, the W, A, S, and D keys, or the arrow keys, are used for vehicle control, and the spacebar serves as the brake. By default, if no modifications are made prior to the test, there are 18 signals at evenly spaced intervals. As the vehicle approaches these signals, panels indicating the direction the driver should take become visible. Once the driver reaches the end of the track, the data is recorded in an Excel spreadsheet. If it is necessary to repeat the test, the driver returns to the starting point; otherwise, they return to the main menu.

Each test is randomly generated on-site, meaning each signal assesses the driver's position and selects the path based on a random number and a number indicating the remaining transitions. The X and Z positions of the driver are recorded every 0.5 seconds, along with the expected positions. After completing the test, this data is transferred to an Excel spreadsheet to create a graphical representation of the route taken.

In addition to adhering to the standards set by the LCT, this project includes an options menu that allows adjustments to various aspects of the test, such as speed, signal spacing, the distance at which signals appear to the driver, and track length.

The goal in creating this project is to establish standardized tests based on the LCT but in a more up-to-date version, improving various aspects such as portability, installation simplicity, and data collection. Unity was chosen for development due to its reputation as a widely recognized game development tool known for its portability and ease of installation. Data is collected using an Excel spreadsheet, making data comparison more straightforward.

The necessary setup requires a computer capable of running Unity.

The program consists of several components, including the Main Menu, which allows exiting, adjusting options, or starting the test. Additionally, there is a form that requests an ID and the number of repetitions before redirecting to the test.

teste de conduçao
![Exemplo do teste de conduçao](https://github.com/TiagoNoite/Lane-Change-Test/blob/main/teste%20condu%C3%A7ao.png?raw=true)

MAin Menu
![Main Menu](https://github.com/TiagoNoite/Lane-Change-Test/blob/main/main%20menu.png?raw=true)

Formulario para o teste
![Formulario](https://github.com/TiagoNoite/Lane-Change-Test/blob/main/Form%20menu.png?raw=true)


Video explicativo do LCT criado
[![LCT video](https://github.com/TiagoNoite/Lane-Change-Test/blob/main/Form%20menu.png?raw=true)](https://youtu.be/mqZ4YszFulQ)
