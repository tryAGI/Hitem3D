#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://docs.hitem3d.ai/en/api/api-reference/overview
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Hitem3D \
  --clientClassName Hitem3DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
