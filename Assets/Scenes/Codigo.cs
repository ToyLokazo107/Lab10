using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigo : MonoBehaviour
{
    public int xSpeed = 1;
    public int xDirection = 1;
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position = new Vector2(_transform.position.x + xSpeed * Time.deltaTime, _transform.position.y + xDirection * Time.deltaTime);

        if (_transform.position.x >= 7.878f)
        {
            xSpeed = xSpeed * -1;
            _spriteRenderer.flipX = true;
        }
        if (_transform.position.x <= -7.878f)
        {
            xSpeed = xSpeed * -1;
            _spriteRenderer.flipX = false;
        }
        if (_transform.position.y >= 3.735f)
        {
            xDirection = xDirection * -1;
            _spriteRenderer.flipY = true;
        }
        if (_transform.position.y <= -3.735f)
        {
            xDirection = xDirection * -1;
            _spriteRenderer.flipY = false;
        }
    }
}