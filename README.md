# STEPS FOLLOWED 📚

◾ create entities to migrate to database -> creates db context.

◾ create interface for repository.

◾ then create class from repository that inherits interface.

◾ create productcontroller.

◾ reference iproductrepository class on program.cs file with AddScoped.

◾ create method GetItems in productcontroller.

◾ create project reference to the shoppingcart.models in dependencies, because this is where the productdto class resigns.

◾ create async get on the controller using the models referenced at dependencies. use try-catch method and if-else to check if the products ou the productCategories are null.

◾ before returning products, create folder named extensions to store class DtoConversions (to simplify code at controller.

◾ later, use the ConvertToDto method created at the previous step to easily convert productDtos to list. return code 200 (Ok) if it worked out with the productDtos collection argument. if exception occurs, return code 500 with an error message.



<b>API</b>

◾ create entities to migrate to database -> creates db context.

◾ create interface for repository.

◾ then create class from repository that inherits interface.

◾ create productcontroller.

◾ reference iproductrepository class on program.cs file with AddScoped.

◾ create method GetItems in productcontroller.

◾ create project reference to the shoppingcart.models in dependencies, because this is where the productdto class resigns.

◾ create async get on the controller using the models referenced at dependencies. use try-catch method and if-else to check if the products ou the productCategories are null.

◾ before returning products, create folder named extensions to store class DtoConversions (to simplify code at controller.

◾ later, use the ConvertToDto method created at the previous step to easily convert productDtos to list. return code 200 (Ok) if it worked out with the productDtos collection argument. if exception occurs, return code 500 with an error message.

◾ create entities to migrate to database -> creates db context.

◾ create interface for repository.

◾ then create class from repository that inherits interface.

◾ create productcontroller.

◾ reference iproductrepository class on program.cs file with AddScoped.

◾ create method GetItems in productcontroller.

◾ create project reference to the shoppingcart.models in dependencies, because this is where the productdto class resigns.

◾ create async get on the controller using the models referenced at dependencies. use try-catch method and if-else to check if the products ou the productCategories are null.

◾ before returning products, create folder named extensions to store class DtoConversions (to simplify code at controller.

◾ later, use the ConvertToDto method created at the previous step to easily convert productDtos to list. return code 200 (Ok) if it worked out with the productDtos collection argument. if exception occurs, return code 500 with an error message.

😗☹☕
