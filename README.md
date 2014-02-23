Owin.Context
============

This package allows you to explicitly define a shared context between middleware for situations where this is permissable such as bootstrapping a framework. Sharing of state between middleware in this way is not encouraged.... where possible share *only* BCL types, through the enviroment dictionary.
