#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://docs.hitem3d.ai/en/api/api-reference/overview

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Hitem3D \
  --clientClassName Hitem3DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
