This is a patched up version of xunit which fixes a bug.

Building it will update the _nuget_abl_ folder which can then be built into a nuget package using nuget (in .nuget -> to be automated).

The version is left as is, I am thinking of upping this to 1.9.2-ablcustom to reflect this, but this may cause trouble with other software that has dependencies on xunit.