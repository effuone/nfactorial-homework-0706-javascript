import { products } from "./data/Products.js";

Array.prototype.contains = function(v)
 {
     for (let i = 0; i < this.length; i++)
     {
       if(this[i] === v) return true;
     }
     return false;
 };
   
 Array.prototype.unique = function()
 {
     let arr = [];
     for (let i = 0; i < this.length; i++)
     {
         if (!arr.contains(this[i]))
         {
             arr.push(this[i]);
         }
     }
     return arr;
 }

const categories = products.map(x=>x.category).unique()

function createCategoryList(categories){
    let selects = document.getElementsByClassName('mt-2 form-select')
    for(let i = 0; i < categories.length; i++)
    {
        let option = document.createElement('option')
        option.value = i+1;
        option.className = 'bg-white'
        option.innerHTML = categories[i]
        selects[0].appendChild(option)
    }
}

const render = () =>
{
    for (let i = 0; i < products.length; i++) {
        const element = products[i];
        if(userSelects.unique().contains(element.category))
        {
            createProduct(
                element.title, 
                element.price,
                element.image,
                element.description
            )
        }
    }
}

function clear()
{
    let containers = document.getElementsByClassName('wrapper bg-white')
    let container = containers[0]
    container.innerHTML = '';
}

const userSelects = []
function collectData()
{
    if(userSelects.length > 0)
    {
        userSelects.length = 0
    }
    clear()
    let itemList = document.getElementById('mySelect')
    let collection = itemList.selectedOptions
    for (let i = 0; i < collection.length; i++) {
        userSelects.push(collection[i].label)
    }
    render()
}
document.getElementById("categoryButton").addEventListener('click', collectData)
function createProduct(name, price, image, description) {
    //get container
    let containers = document.getElementsByClassName('wrapper bg-white')
    let container = containers[0]
    //create new product
    let newProduct = document.createElement('div')
    newProduct.className = "product"

    //create new productName
    let productName = document.createElement('div')
    let productNameText = document.createElement('h2')
    productNameText.innerHTML = name;
    productName.className = "productName"
    productName.appendChild(productNameText)
    newProduct.appendChild(productName)

    //create new description block
    let descriptionBlock = document.createElement('div')
    descriptionBlock.className = "description"
    let productImageBlock = document.createElement('div')
    productImageBlock.className = "productImage"
    let productImageImage = document.createElement('img')
    productImageImage.src = image
    productImageBlock.appendChild(productImageImage)
    descriptionBlock.appendChild(productImageBlock)
    let informationBlock = document.createElement('div')
    informationBlock.className = "information"
    let productDescriptionBlock = document.createElement('div')
    productDescriptionBlock.className = "productDescription"
    productDescriptionBlock.appendChild(document.createTextNode(description))
    let priceTagBlock = document.createElement('div')
    priceTagBlock.className = "priceTag"
    let priceTextBlock = document.createElement('div')
    priceTextBlock.className = "priceText"
    priceTextBlock.innerHTML = price + ' $'
    priceTagBlock.appendChild(priceTextBlock)
    
    

    //create basket button block
    let button = document.createElement('button')
    button.className= 'basketButtonBlock'
    button.type = 'button'
    button.appendChild(document.createTextNode('Add'))

    informationBlock.appendChild(productDescriptionBlock)
    informationBlock.appendChild(priceTagBlock)
    informationBlock.appendChild(button)

    descriptionBlock.appendChild(informationBlock)
    newProduct.appendChild(descriptionBlock)

    container.appendChild(newProduct);
}


function showProducts(){
    createCategoryList(categories)
    render()
}

window.onload = function(){
    showProducts()
}