# Grammophone.DataAccess.Tests.Domain

Portable music-domain model used by the Grammophone data access test suites.

This project defines the provider-neutral test entities and `IMusicDomainContainer` contract used by both EF6 and EF Core test implementations. It references the query abstraction contracts from [Grammophone.DataAccess](https://github.com/grammophone/Grammophone.DataAccess), but does not reference any concrete ORM provider.

The model includes `Artist`, `Album`, `Track`, and `Genre`, providing reference navigations, collection navigations, nested eager-loading paths, aggregate-friendly scalar fields, and constraint scenarios for integration tests.
