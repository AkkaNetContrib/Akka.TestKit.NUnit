#### 1.5.34 January 7th 2025 ####
- Bump `Akka.TestKit` to [1.5.34](https://github.com/akkadotnet/akka.net/releases/tag/1.5.34)

#### 1.5.33 January 4th 2025 ####
- Safer formatting of assertion messages
- Bump `NUnit` to [4.3.2](https://github.com/nunit/nunit/releases/tag/4.3.2)
- Bump `NUnit.Analyzers` to [4.5.0](https://github.com/nunit/nunit.analyzers/releases/tag/4.5.0)
- Bump `Akka.TestKit` to [1.5.33](https://github.com/akkadotnet/akka.net/releases/tag/1.5.33)

#### 1.5.32 December 20th 2024 ####
- Bump `Akka.TestKit` to [1.5.32](https://github.com/akkadotnet/akka.net/releases/tag/1.5.32)
- Bump `NUnit3TestAdapter` to [4.6.0](https://github.com/nunit/nunit3-vs-adapter/releases/tag/V4.6.0)
- Add `NUnit.Analyzers` version [4.3.0](https://github.com/nunit/nunit.analyzers/releases/tag/4.3.0) to ensure we follow NUnit best practices.
- Add support for [NUnit 4.2.2](https://github.com/nunit/nunit/releases/tag/4.2.2)

`Akka.TestKit.NUnit3` package is now deprecated, `Akka.TestKit.NUnit` will support NUnit 4 from now on.

#### 1.5.24 June 11 2024 ####
- Bump Akka.TestKit to [1.5.24](https://github.com/akkadotnet/akka.net/releases/tag/1.5.24) ([#124](https://github.com/akkadotnet/Akka.TestKit.NUnit/pull/124))
- Bump NUnit3TestAdapter to [4.5.0](https://github.com/nunit/nunit3-vs-adapter/releases/tag/V4.5.0) ([#97](https://github.com/akkadotnet/Akka.TestKit.NUnit/pull/97))
- Bump NUnit to [3.14.0](https://github.com/nunit/nunit/releases/tag/v3.14.0) ([#116](https://github.com/akkadotnet/Akka.TestKit.NUnit/pull/116))

#### 1.4.39 July 22 2022 ####
- Support for Akka 1.4.39
- Support for NUnit 3.13.3
- Now targets `netstandard2.0`
- All `TestKit` classes now implement `[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]` which guarantees a unique `ActorSystem` instance per-run. All previous TestKit hacks needed to support this are now removed. See [#44](https://github.com/akkadotnet/Akka.TestKit.NUnit/issues/44) for details.
