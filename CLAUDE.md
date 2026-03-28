# CLAUDE.md — BlandAI SDK

## Overview

Auto-generated C# SDK for [Bland AI](https://bland.ai/) — enterprise-grade platform for AI-powered phone calls covering outbound/inbound calls, batch campaigns, conversational pathways, phone number management, voice selection, and account/billing.
**No public OpenAPI spec exists** — `openapi.yaml` was manually created from Bland AI API documentation.

## Build & Test

```bash
dotnet build BlandAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new BlandAIClient(apiKey); // BLANDAI_API_KEY env var
```

## Key Files

- `src/libs/BlandAI/openapi.yaml` — **Manually maintained** OpenAPI spec (no public spec from Bland AI)
- `src/libs/BlandAI/generate.sh` — Runs autosdk generate (no download step, locally maintained spec)
- `src/libs/BlandAI/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Sub-Clients

| Sub-Client | Operations |
|------------|-----------|
| `CallsClient` | SendCall, ListCalls, GetCallDetails, GetCallRecording, AnalyzeCall, ListActiveCalls, StopCall, StopAllActiveCalls |
| `BatchesClient` | CreateBatch, ListBatches, GetBatch, GetBatchLogs, StopBatch |
| `PathwaysClient` | CreatePathway, ListPathways, GetPathway, UpdatePathway, DeletePathway |
| `NumbersClient` | ListInboundNumbers, GetInboundNumber, PurchaseNumber, UpdateInboundNumber |
| `VoicesClient` | ListVoices |
| `AccountClient` | GetAccountDetails |

## Spec Notes

- **No public OpenAPI spec exists** — `openapi.yaml` was manually created from docs.bland.ai
- Base URL: `https://api.bland.ai`
- Auth: Standard HTTP Bearer — no jq/yq auth fixes needed
- 24 operations across 6 tags (Calls, Batches, Pathways, Numbers, Voices, Account)
