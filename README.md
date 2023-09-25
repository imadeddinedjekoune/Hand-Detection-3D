# Hand-Detection-3D

My project combines computer vision with 3D modeling and real-time 3D rendering to create a realistic hand model in Unity that mimics the movement of a user's hand. It utilizes OpenCV and MediaPipe for hand tracking in Python, a Blender-modeled and textured hand, and a UDP connection to transmit hand tracking data to Unity for rendering.
## Demo 
[![Watch the video](https://github-production-user-asset-6210df.s3.amazonaws.com/75379150/270224152-4304f8eb-551a-40ce-9c06-b5696c73e1c6.PNG)](https://www.youtube.com/watch?v=Dl0FvKSwzv8)


## Table of Contents

- [Introduction](#introduction)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

This project aims to create a compelling and realistic virtual hand that follows the movements of a user's real hand. It integrates several key technologies, including computer vision, 3D modeling, texturing, and real-time rendering. By combining these elements, we've achieved a highly immersive and interactive experience.

## Project Details and Technical Explanation

In this section, we'll dive deeper into the theories, methodologies, and technical steps behind this project to create a comprehensive understanding of how it works.

### Computer Vision and Hand Tracking (Python):

This project leverages computer vision techniques using OpenCV and MediaPipe to perform real-time hand tracking. OpenCV provides a robust framework for image and video analysis, while MediaPipe offers a pre-trained hand tracking model.
The tracking model identifies key hand landmarks, resulting in 20 data points representing joints on the hand. These landmarks serve as the foundation for tracking hand movements.
3D Modeling and Rigging (Blender):

<p align="center">
  <img src="https://github.com/imadeddinedjekoune/AR-Hand-Detection/assets/75379150/13a2d84e-b2d9-4094-9d41-23c7687976af" width="400"/>
  <img src="https://github.com/imadeddinedjekoune/AR-Hand-Detection/assets/75379150/76ec1003-a7f6-4cc3-a96b-2834500b9766" width="400"/>
</p>

To create a realistic 3D hand model, we utilize Blender, a popular 3D modeling software. In Blender, we model, texture, and rig a hand mesh to match the tracked hand landmarks from the computer vision model.
Rigging involves creating a skeleton (armature) that matches the bone structure of a human hand. The armature is then linked to the hand mesh, enabling it to deform realistically based on joint movements.

### Unity Integration:

Unity is used as the real-time 3D rendering engine. It allows us to import the Blender-modeled hand and apply real-time animations based on the tracked hand landmarks.
To establish communication between the Python hand tracking script and Unity, we employ a UDP (User Datagram Protocol) connection. This lightweight and efficient protocol ensures that tracking data is transmitted in real-time.

### Realistic Hand Movement:

As the Python script tracks the user's hand and sends the landmark data to Unity, the hand model in Unity is animated to replicate the hand's movements accurately.
Unity's animation system is used to map the received data to the hand's armature, enabling realistic and synchronized movement.

## Getting Started

To run this project locally, follow these steps:

- Clone the repository.
- Ensure you have Python, OpenCV, MediaPipe, Blender, and Unity installed.
- Set up a UDP connection between the Python script (hand detector) and Unity.
- Run the Python script for hand tracking.
- Launch the Unity project.
- Enjoy the realistic hand model that mirrors your hand's movements!


## Usage

To use the project, follow these instructions:

- Launch the Python script responsible for hand tracking.
- Start the Unity project.
- The 3D hand model in Unity should now mimic the movements of your real hand, providing a realistic and interactive experience.

You can further customize the Unity project to incorporate the hand model into your desired application or scenario.

## Contributing

We welcome contributions to enhance this project! If you'd like to contribute, please follow these guidelines:

- Fork the repository.
- Make your improvements or additions.
- Submit a pull request, providing a detailed explanation of your changes.

We'll review your contribution and merge it if it aligns with the project's goals.

## License

This project is licensed under the MIT License - see the LICENSE file for details.


## Contact:

If you have any questions or need further assistance, feel free to contact me at [imaddjekoune@gmail.com](mailto:imaddjekoune@gmail.com).
