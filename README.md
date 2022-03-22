# EchoServer

This is a .net mini api that will echo a request.

The intention of this projects is to create a .net docker image for training purposes.

## To build a new docker image

``` bash
docker build -t rulasg/echoserver:arm64 -f Dockerfile .

```

## To run de docker image to test

``` bash

docker run -P rulasg/echoserver:arm64

```

## To push the new image to Docker hub

``` bash

docker push rulasg/echoserver:arm64

```

## To run the docker image to test on a different machine

> No need to specify the tag as this registry is multiplatform
> [Multi-arch build and images, the simple way](https://www.docker.com/blog/multi-arch-build-and-images-the-simple-way/)

``` bash

docker run -P rulasg/echoserver

```
