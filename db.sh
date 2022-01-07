#!/usr/bin/env bash

db_docker="DockerDb/docker-compose.db.yml"

echo "Using docker-compose ${db_docker}"

if [[ "${1}" = "restart" ]]; then
  docker-compose --file "${db_docker}" down
  docker-compose --file "${db_docker}" up -d
else
  docker-compose --file "${db_docker}" "$@"
fi