# Button group component

Component composed from several [Button](/components/button) components.

<div class="skittles-components-sample">
    <div class="button-group">
        <a class="button">First</a>
        <a class="button">Second</a>
        <a class="button">Third</a>
    </div>
</div>

```html
<div class="button-group">
    <a class="button">First</a>
    <a class="button">Second</a>
    <a class="button">Third</a>
</div>
```

With that you're able to create a dropdown button.

<div class="skittles-components-sample">
    <div class="button-group">
        <a class="button button--primary">Dropdown</a>
        <a class="button button--primary button--squeez">
            <svg class="icon"><use xlink:href="#chevron-down" /></svg>
        </a>
    </div>
</div>

```html
<div class="button-group">
    <a class="button button--primary">Dropdown</a>
    <a class="button button--primary button--squeez">
        <svg class="icon"><use xlink:href="#chevron-down" /></svg>
    </a>
</div>
```