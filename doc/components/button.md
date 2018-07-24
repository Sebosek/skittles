# Button component

A button is component element used for navigation or to do any kind of action. 

## Primary button
Primary button is used for **primary actions** which are an actions intended to be single use case on given screen thus only one primary button should be displayed on screen in one moment.

<div class="skittles-components-sample">
    <button class="button--primary" tabindex="1"><span>Primary button</span></button>
    <button type="submit" tabindex="1"><span>Primary button</span></button>
    <a class="button button--primary" tabindex="1"><span>Primary button</span></a>
    <a class="button button--primary button--link" tabindex="1"><span>Primary link button</span></a>
</div>

```html
<button class="primary"><span>Primary button</span></button>
<button type="submit"><span>Primary button</span></button>
<a class="button button--primary"><span>Primary button</span></a>
<a class="button button--primary button--link"><span>Primary link button</span></a>
```

### Primary button states
<div class="skittles-components-sample">
    <button class="button button--primary button--hover" tabindex="2"><span>Hover</span></button>
    <button class="button button--primary button--focus" tabindex="2"><span>Focus</span></button>
    <button class="button button--primary button--active" tabindex="2"><span>Active</span></button>
</div>

```html
<button class="button button--primary button--hover" tabindex="2"><span>Hover</span></button>
<button class="button button--primary button--focus" tabindex="2"><span>Focus</span></button>
<button class="button button--primary button--active" tabindex="2"><span>Active</span></button>
```

## Danger button
Danger buttons are intended to use for **destructiove** actions which are an actions intended to remove or disable resource.

<div class="skittles-components-sample">
    <button class="button--danger" tabindex="3"><span>Danger button</span></button>
    <button type="reset" tabindex="3"><span>Danger button</span></button>
    <a class="button button--danger" tabindex="3"><span>Danger button</span></a>
    <a class="button button--danger button--link" tabindex="3"><span>Danger link button</span></a>
</div>

```html
<button class="button--danger"><span>Danger button</span></button>
<button type="reset"><span>Danger button</span></button>
<a class="button button--danger"><span>Danger button</span></a>
<a class="button button--danger button--link" tabindex="3"><span>Danger link button</span></a>
```

### Danger button states
<div class="skittles-components-sample">
    <button class="button button--danger button--hover" tabindex="4"><span>Hover</span></button>
    <button class="button button--danger button--focus" tabindex="4"><span>Focus</span></button>
    <button class="button button--danger button--active" tabindex="4"><span>Active</span></button>
</div>

```html
<button class="button button--primary button--hover" tabindex="4"><span>Hover</span></button>
<button class="button button--primary button--focus" tabindex="4"><span>Focus</span></button>
<button class="button button--primary button--active" tabindex="4"><span>Active</span></button>
```

## Neutral button
Neutral buttons are intended for **neutral** actions which are any other action.

<div class="skittles-components-sample">
    <button tabindex="5"><span>Neutral button</span></button>
    <a class="button" tabindex="5"><span>Neutral button</span></a>
    <a class="button button--link" tabindex="5"><span>Neutral link button</span></a>
</div>

```html
<button><span>Neutral button</span></button>
<a class="button"><span>Neutral button</span></a>
<a class="button button--link"><span>Neutral link button</span></a>
```

### Neutral button states
<div class="skittles-components-sample">
    <button class="button button--hover" tabindex="6"><span>Hover</span></button>
    <button class="button button--focus" tabindex="6"><span>Focus</span></button>
    <button class="button button--active" tabindex="6"><span>Active</span></button>
</div>

```html
<button class="button button--hover" tabindex="6"><span>Hover</span></button>
<button class="button button--focus" tabindex="6"><span>Focus</span></button>
<button class="button button--active" tabindex="6"><span>Active</span></button>
```

## Button sizes
For all buttons there are three defined sizes default size, small size and also big size button.
<div class="skittles-components-sample">
    <button class="button--small" tabindex="9"><span>Small neutral button</span></button>
    <button tabindex="10"><span>Default size neutral button</span></button>
    <button class="button--big" tabindex="11"><span>Big neutral button</span></button>
</div>

```html
<button class="button--small"><span>Small neutral button</span></button>
<button><span>Default size neutral button</span></button>
<button class="button--big"><span>Big neutral button</span></button>
```

## Circle button
<div class="skittles-components-sample">
    <a class="button button--small button--circle" tabindex="9">
        <span>
            <svg class="icon"><use xlink:href="#ghost" /></svg>
        </span>
    </a>
    <a class="button button--circle" tabindex="9">
        <span>
            <svg class="icon"><use xlink:href="#ghost" /></svg>
        </span>
    </a>
    <a class="button button--big button--circle" tabindex="9">
        <span>
            <svg class="icon"><use xlink:href="#ghost" /></svg>
        </span>
    </a>
</div>

```html
<a class="button button--small button--circle" tabindex="9">
    <span><svg class="icon"><use xlink:href="#ghost" /></svg></span>
</a>
<a class="button button--circle" tabindex="9">
    <span><svg class="icon"><use xlink:href="#ghost" /></svg></span>
</a>
<a class="button button--big button--circle" tabindex="9">
    <span><svg class="icon"><use xlink:href="#ghost" /></svg></span>
</a>
```

## Button stretch and squeez

<div class="skittles-components-sample">
    <button class="button button--stretch"><span>Stretch button</span></button>
</div>
<div class="skittles-components-sample">
    <button class="button button--squeez"><span>Squeez button</span></button>
</div>


```html
<button class="button button--stretch"><span>Stretch button</span></button>
<button class="button button--squeez"><span>Squeez button</span></button>
```

## Button with icon

<div class="skittles-components-sample">
    <a class="button button--icon">
        <span class="button__icon">
            <svg class="icon"><use xlink:href="#plus" /></svg>
        </span>
        <span>Add resource</span>
    </a>
</div>

```html
<a class="button button--icon">
    <span class="button__icon">
        <svg class="icon"><use xlink:href="#plus" /></svg>
    </span>
    <span>Add resource</span>
</a>
```