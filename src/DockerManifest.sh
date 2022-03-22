# [Multi-arch build and images, the simple way](https://www.docker.com/blog/multi-arch-build-and-images-the-simple-way/)

docker manifest create rulasg/echoserver:latest --amend rulasg/echoserver:amd64 --amend rulasg/echoserver:arm64v8

docker manifest push rulasg/echoserver:latest